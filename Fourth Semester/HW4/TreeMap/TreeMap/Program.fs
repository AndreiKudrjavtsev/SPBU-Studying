type Tree<'a> = 
    | Tree of 'a * Tree<'a> * Tree<'a> 
    | Leaf of 'a

let rec treeMap func tree = 
    match tree with
    | Leaf(a) -> Leaf(func a)
    | Tree(a, l, r) -> Tree(func a, treeMap func l, treeMap func r)