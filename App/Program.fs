let config = ConfigDSL.runConfig "myConfig.fsx"
let config2 = ConfigDSL.runConfig "myConfig2.fsx"

let completeConfig = ConfigDSL.merge config config2

for x in completeConfig do
    printfn "%s => %s" x.Key x.Value

System.Console.ReadKey() |> ignore