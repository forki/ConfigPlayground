let config = ConfigDSL.runConfig "myConfig.fsx"

for x in config do
    printfn "%s => %s" x.Key x.Value

System.Console.ReadKey() |> ignore