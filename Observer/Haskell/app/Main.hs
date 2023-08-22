module Main (main) where

import WeatherData


main :: IO ()
main = do
    displays <- return
        [CurrentConditions 0 0, Forecast 0 0, Statistics 0 0 0 0, HeatIndex 0]
    displays <- return $ updateWeatherInfo (WeatherData 80 65 30.4) <$> displays
    putStrLn $ unlines (displayWeatherInfo <$> displays)
    displays <- return $ updateWeatherInfo (WeatherData 82 70 29.2) <$> displays
    putStrLn $ unlines (displayWeatherInfo <$> displays)
    displays <- return $ updateWeatherInfo (WeatherData 78 90 29.2) <$> displays
    putStrLn $ unlines (displayWeatherInfo <$> displays)