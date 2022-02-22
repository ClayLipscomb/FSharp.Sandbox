let shuffleArrayOfIntegers (sourceArray: int[])  =
    let random = System.Random()    
    /// Swap element with random element in array
    let swapElementWithRandom index arr =
        let indexRandom = random.Next(maxValue = Array.length arr)
        if index = indexRandom then
            ()
        else            
            let index1Value = arr[index]
            arr[index] <- arr[indexRandom]
            arr[indexRandom] <- index1Value

    let shuffledArray = sourceArray
                        |> Array.copy
    shuffledArray
    |> Array.iteri (fun idx _ -> shuffledArray |> swapElementWithRandom idx)
        
    shuffledArray
        
#time "on"
let shuffled = [|1..100_000|]
               |> shuffleArrayOfIntegers
shuffled
#time "off"          