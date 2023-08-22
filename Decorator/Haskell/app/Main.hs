module Main (main) where

import Coffee


main :: IO ()
main = do
    espresso <- return $ Beverage "Espresso" 1.99
    print espresso

    darkRoast <- return $ Beverage "Dark Roast" 0.99
    mocha <- return $ Beverage "Mocha" 0.2
    whip <- return $ Beverage "Whip" 0.1
    soy <- return $ Beverage "Soy" 0.15
    beverage <- return $ darkRoast <> mocha <> mocha <> whip
    print beverage

    houseBlend <- return $ Beverage "House Blend" 0.89
    beverage <- return $ houseBlend <> soy <> mocha <> whip
    print beverage