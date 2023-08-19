module Main (main) where

import Ducks


main :: IO ()
main = do
    mallard <- return mallardDuck
    putStrLn $ quack mallard
    putStrLn $ fly mallard

    model <- return decoyDuck
    putStrLn $ quack model
    putStrLn $ fly model
    newModel <- return $ model {fly = flyRocketPowered}
    putStrLn $ fly newModel