open System
open System.Linq

let chartointarray (array : String []) =
    [|for i in 0..array.Length-1 do
        yield array.[i]|>System.Int32.Parse
    done|]

[<EntryPoint>]
let main argv = 
    let all : int = Console.ReadLine() |> System.Int32.Parse

    let my_num : int = Console.ReadLine() |> System.Int32.Parse
    let my_books = Console.ReadLine().Split [|' '|]

    let sold_num : int = Console.ReadLine() |> System.Int32.Parse
    let sold_books = Console.ReadLine().Split [|' '|]

    let buy_books_str = (set sold_books).Except(set my_books)

    let buy_books_int = chartointarray (buy_books_str|>Seq.toArray)
    
    let buy_books = Array.sort(buy_books_int)

    //printf "%A" buy_books

    if buy_books.Length = 0 then 
        printf "None"
    else 
        for i in 0..buy_books.Length-1 do
            printf "%d" buy_books.[i]
            if i < buy_books.Length-1 then
                printf " "
        done
    0