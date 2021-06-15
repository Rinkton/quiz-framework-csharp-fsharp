namespace SlaveUnit

open Xunit
open Xunit.Abstractions
open Slave

module Say =
    let hello name =
        printfn "Hello %s" name
