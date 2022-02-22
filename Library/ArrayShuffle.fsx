
module Shuffle 
#time "on"

//module ArrayShuffle =       
    ///let rnd = System.Random(3)
    //let rndNmbr = rnd.Next(0,9 )    
//    let coll = [1..10]
//    let shuffled = coll
//                   |> Array.permute (fun i -> rnd.Next(0, 9))
//    let shuffled3 = coll
//                    |> Array.permute (fun i -> (i + 3) % 10)
//    let shuffledSort = coll
//                       |> Seq.sortBy (fun _ -> rnd.Next())
//                       |> Array.ofSeq

let shuffleBySort randomizerSeed (sourceArray: int[]) =
    let rnd = System.Random(randomizerSeed)
    sourceArray
    |> Array.sortBy (fun _ -> rnd.Next())
    
let shuffleArrayOfIntegers (sourceArray: int[]) =
    /// Swap two elements in array
    let swapElements index1 index2 (arr: int []) =
        let index1Value = arr[index1]
        arr[index1] <- arr[index2]
        arr[index2] <- index1Value
        //Array.set arr index2 index1Value
        arr        
    sourceArray
        
let arr = [|1..1000|]
let shuffled =
    arr
    |> shuffleBySort 3
    
#time "off"
            