open System

[<EntryPoint>]
let main argv =
    Console.WriteLine "CSCI 6221 - Hw #7 - Sam Odle"
    Console.WriteLine "Initial list of items:"

    //note - in F#, all elements of a list must have same type as 1st elem
    let list = [["A";"B";"C"];["D";"E";"F"];["G";"H"]]
    Console.WriteLine list

    //declare function to reverse the list
    let reverseList in_list =
        let rec loop temp = function
            | [] -> temp
            | a :: b -> loop (a :: temp) b
        loop [] in_list
    
    let revFinal masterList =
        List.fold (fun s x -> (reverseList x) ::s ) [] masterList
      
    let reverse_list = revFinal list
    
    Console.WriteLine "Reversed List Of Items:"
    Console.WriteLine reverse_list
    0 // return an integer exit code
