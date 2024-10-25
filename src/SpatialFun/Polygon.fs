namespace SpatialFun

module Polygon =

    let private lace ((x1, y1), (x2, y2)) =
        (x1 * y2) - (y1 * x2)

    // uses the shoe lace algorithm for finding the area of a polygon
    // https://en.wikipedia.org/wiki/Shoelace_formula
    let area (points: seq<float * float>) : float =
        (points
        |> Seq.pairwise
        |> Seq.map lace
        |> Seq.sum) / 2.0

