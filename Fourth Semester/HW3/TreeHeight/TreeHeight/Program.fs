type Tree<'a> = 
    | Tree of 'a * Tree<'a> * Tree<'a>
    | Leaf of 'a 

let rec treeHeight tree = 
    match tree with 
    | Tree(_, l, r) -> 1 + max (treeHeight l) (treeHeight r)
    | Leaf _ -> 1 

let testTree = Tree(1, Tree(1, Leaf(2), Leaf(3)), Tree(2, Leaf(1), Tree(0, Leaf(0), Leaf(0)))) 
printfn "%A" (treeHeight testTree)