module Tests

open System
open Xunit
open FsUnit.Xunit
open SpatialFun

[<Fact>]
let ``My test`` () =
    Assert.True(true)

[<Fact>]
let ``Polygon area`` () =
    let polygonPoints = [(1.0, 6.0); (3.0, 1.0); (7.0, 2.0); (4.0, 4.0); (8.0, 5.0); (1.0, 6.0)]

    Polygon.area polygonPoints |> should (equalWithin 0.0001) 16.5
