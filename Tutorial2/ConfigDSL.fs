[<AutoOpen>]
module ConfigDSL

open System.IO

type ConfigValue = {
  Key: string
  Value: string
}


let loadConfig fileName =
    File.ReadAllLines fileName
    |> Seq.map (fun s -> s.Split(','))
    |> Seq.map (fun xs -> { Key = xs.[0]; Value = xs.[1]})