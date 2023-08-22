module Ducks where


type Fly = String
type Quack = String
type Swim = String
type Display = String

data Duck = Duck
    { fly :: Fly
    , quack :: Quack
    , swim :: Swim
    , display :: Display
    }
    deriving (Eq, Show)

flyNoWay :: Fly
flyNoWay = "I can't fly"

flyWithWings :: Fly
flyWithWings = "I'm flying!!"

flyRocketPowered :: Fly
flyRocketPowered = "I'm flying with a rocket!"

normalQuack :: Quack
normalQuack = "Quack"

muteQuack :: Quack
muteQuack = "<< Silence >>"

squeak :: Quack
squeak = "Squeak"

normalSwim :: Swim
normalSwim = "All ducks float, even decoys!"

mallardDuck :: Duck
mallardDuck = Duck flyWithWings normalQuack normalSwim "I'm a real Mallard duck"

decoyDuck :: Duck
decoyDuck = Duck flyNoWay normalQuack normalSwim "I'm a model duck"