{-# LANGUAGE InstanceSigs #-}
module Coffee where


data Beverage =
    Beverage
    { getDescription :: String
    , getCost :: Float }
    deriving Eq

instance Show Beverage where
    show :: Beverage -> String
    show (Beverage d c) = d ++ " $" ++ show c

instance Semigroup Beverage where
    (<>) :: Beverage -> Beverage -> Beverage
    Beverage d c <> Beverage d' c' = Beverage (d ++ ", " ++ d') (c + c')

instance Monoid Beverage where
    mempty :: Beverage
    mempty = Beverage "" 0

    mappend :: Beverage -> Beverage -> Beverage
    mappend = (<>)