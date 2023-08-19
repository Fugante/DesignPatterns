module Main (main) where


import Data.Maybe (fromJust)
import PizzaStore


main :: IO ()
main = do
    pizza <- return $ fromJust $ makePizza CheesePizza "New York Style Cheese Pizza" newYorkIngredients
    print $ pizza