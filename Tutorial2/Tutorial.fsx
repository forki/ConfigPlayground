#load "ConfigDSL.fs"

let configFileName = __SOURCE_DIRECTORY__ + "/myConfig.txt"

let myConfig = loadConfig configFileName