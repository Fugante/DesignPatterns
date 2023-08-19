module WeatherData where


type Temperature = Float
type Humidity = Float
type Pressure = Float
type HeatIndex = Float

data WeatherData =
    WeatherData
    { getTemperature :: Temperature
    , getHumidity :: Humidity
    , getPressure :: Pressure }
    deriving (Eq, Show)

data WeatherInfo =
      CurrentConditions
      { getCurrentTemperature :: Temperature
      , getCurrentHumidity :: Humidity }
    | Forecast
      { getCurrentPressure :: Pressure
      , getLastPressure :: Pressure }
    | Statistics
      { getMaxTemperature :: Temperature
      , getMinTemperature :: Temperature
      , getTemperatureSum :: Temperature
      , getNumReadings :: Int }
    | HeatIndex
      { getHeatIndex :: HeatIndex }
    deriving (Eq, Show)


computeHeatIndex :: Temperature -> Humidity -> HeatIndex
computeHeatIndex t rh =
    (    16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh)
      + (0.00941695 * (t * t)) + (0.00728898 * (rh * rh)) + (0.000345372 * (t * t * rh))
      - (0.000814971 * (t * rh * rh)) + (0.0000102102 * (t * t * rh * rh))
      - (0.000038646 * (t * t * t)) + (0.0000291583 * (rh * rh * rh))
      + (0.00000142721 * (t * t * t * rh)) + (0.000000197483 * (t * rh * rh * rh))
      - (0.0000000218429 * (t * t * t * rh * rh))
      + 0.000000000843296 * (t * t * rh * rh * rh)
    ) - ( 0.0000000000481975 * (t * t * t * rh * rh * rh) )

updateWeatherInfo :: WeatherData -> WeatherInfo -> WeatherInfo
updateWeatherInfo (WeatherData t _ h) (CurrentConditions _ _) = CurrentConditions t h
updateWeatherInfo (WeatherData t _ _) (Forecast cp _) = Forecast t cp
updateWeatherInfo (WeatherData t _ _) (Statistics maxT minT sumT numR)
    | t > maxT = Statistics t minT (sumT + t) (numR + 1)
    | t < minT = Statistics maxT t (sumT + t) (numR + 1)
    | otherwise = Statistics maxT minT (sumT + t) (numR + 1)
updateWeatherInfo (WeatherData t p h) _ = HeatIndex $ computeHeatIndex t h

displayWeatherInfo :: WeatherInfo -> String
displayWeatherInfo (CurrentConditions t h) =
    concat ["Current conditions: ", show t, " F degrees ", show h, " % humidity"]
displayWeatherInfo (Forecast cp lp)
    | cp > lp = "Forecast: Improving weather on the day!"
    | cp == lp = "Forecast: More of the same"
    | otherwise = "Forecast: Watch out for cooler, rainy weather"
displayWeatherInfo (Statistics maxT minT sumT numR) =
    concat [ "Avg/Max/Min temperature = "
           , show $ sumT / fromIntegral numR
           , "/"
           , show maxT
           , "/"
           , show minT ]
displayWeatherInfo (HeatIndex hi) = "Heat Index is " ++ show hi