open System
open System.IO


let nt = File.ReadAllText("F:/Shawn Google Drive/Source/Nucleotides.txt")

let Total_A = 
    String.filter(fun x -> x = 'A') nt
    |> String.length

let Total_C = 
    String.filter(fun x -> x = 'C') nt
    |> String.length

let Total_G = 
    String.filter(fun x -> x = 'G') nt
    |> String.length

let Total_T = 
    String.filter(fun x -> x = 'T') nt
    |> String.length


printfn "%i %i %i %i" Total_A Total_C Total_G Total_T

System.Console.ReadLine() |> ignore