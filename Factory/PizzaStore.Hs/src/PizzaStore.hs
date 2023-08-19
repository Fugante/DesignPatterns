module PizzaStore where

import qualified Data.Map as Map
import Data.Maybe
    ( isNothing
    , fromJust )


type PizzaName = String

data PizzaStyle = CheesePizza | ClamsPizza
    deriving (Eq, Show)

data Dough = ThinCrustDough
    deriving (Eq, Show)

data Sauce = MarinaraSauce
    deriving (Eq, Show)

data Cheese = ReggianoCheese
    deriving (Eq, Show)

data Veggie = Garlic | Onion | Mushroom | RedPepper
    deriving (Eq, Show)

data Pepperoni = SlicedPepperoni
    deriving (Eq, Show)

data Clams = FreshClams
    deriving (Eq, Show)

data Ingredient =
      Veggie Veggie
    | Pepperoni Pepperoni
    | Clams Clams
    | Sauce Sauce
    deriving (Eq, Show)

data RegionIngredients = RegionIngredients
    { getRegionDough :: Dough
    , getRegionCheese :: Cheese
    , getRegionIngredients :: Map.Map String [Ingredient]
    }
    deriving (Eq, Show)

data Pizza = Pizza
    { getName :: PizzaName
    , getDough :: Dough
    , getCheese :: Cheese
    , getIngredients :: Map.Map String [Ingredient]
    } deriving (Eq, Show)


newYorkIngredients =
      RegionIngredients ThinCrustDough ReggianoCheese
    $ Map.fromList
        [ ("sauce", [Sauce MarinaraSauce])
        , ("veggies", [Veggie Garlic, Veggie Onion, Veggie Mushroom, Veggie RedPepper])
        , ("pepperoni", [Pepperoni SlicedPepperoni])
        , ("clams", [Clams FreshClams]) ]


makePizza :: PizzaStyle -> PizzaName -> RegionIngredients -> Maybe Pizza
makePizza CheesePizza name (RegionIngredients dough cheese ingredients)
    | isNothing sauce = Nothing
    | otherwise =
          Just
        $ Pizza name dough cheese
        $ Map.fromList [("sauce", fromJust sauce)]
    where
        sauce = Map.lookup "sauce" ingredients
makePizza ClamsPizza name (RegionIngredients dough cheese ingredients)
    | any isNothing [sauce, clams] = Nothing
    | otherwise =
          Just
        $ Pizza name dough cheese
        $ Map.fromList [("sauce", fromJust sauce), ("clams", fromJust clams)]
    where
        sauce = Map.lookup "sauce" ingredients
        clams = Map.lookup "clams" ingredients