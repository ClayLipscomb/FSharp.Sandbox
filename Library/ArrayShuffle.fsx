let shuffleArrayOfIntegers (sourceArray: int[])  =
    let random = System.Random()    
    /// Swap element with random element in array
    let swapElementWithRandom index arr =
        let indexRandom = (random.Next(0, (Array.length arr) - 1))
        if index = indexRandom then
            ()
        else            
            let index1Value = arr[index]
            arr[index] <- arr[indexRandom]
            arr[indexRandom] <- index1Value
        
    sourceArray
    |> Array.copy
    |> fun shuffledArray ->
        shuffledArray
        |> Array.iteri (fun idx arr -> shuffledArray |> swapElementWithRandom idx)
        shuffledArray
        
#time "on"
let shuffled = [|1..100000|]
               |> shuffleArrayOfIntegers
shuffled
#time "off"
            