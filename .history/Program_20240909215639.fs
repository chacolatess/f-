open System
[<EntryPoint>]
let main argv =
    printfn "F# is ready to go!"
    0

let x=5
let y = x+10

let add a b = a+b
let result = add 3 4


let checkNumber n = 
if n >0 then "Positive"
elif n <0 then "Negative"
else "zero"

let describeNumber n =
match n with 
|0 -> "zero"
|1 -> "ONe"
 3 ->"Other number"


let numbers  =[1;2;3;4;5]
let doubled = List.map (fun x ->x*2) numbers


let rec factorial n = 
if n =1 then 1
else n*factorial (n-1)
let result = factorial 5
type shape =
   | Circle of float 
   | Rectangle of float * fsharp-console-apps

let area shape =
match shape with 
|Circle radius -> Math.PI *radius*radius

|Rectangle 

let half x =x/2
let result  4 |> squa|> half //(    )