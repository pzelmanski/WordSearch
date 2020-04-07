module Tests

open NUnit.Framework
open WordSearchKata.Interpreter


[<Test>]
let ``Find word that exists``() =

    // Setup
    let characters  = [ "jefblpepre"; "camdcimgtc"; "oivokprjsm"; "pbwasqroua"; "rixilelhrs"; "wolcqlirpc"; "screeaumgr"; "alxhpburyi"; "jalaycalmp"; "clojurermt" ]
    let wordMatches = ["clojure";"calm"]

    // Test
    wordMatches 
    |> WordSearch.findIn characters
    |> function
       | _::_::[] -> ()
       | [] -> Assert.Fail()
       | _  -> Assert.Fail()

[<Test>]
let ``Find word that doesn't exist``() =

    // Setup

    // Test

    // Verify
    Assert.Fail()
