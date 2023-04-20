module App

open Sutil
open Sutil.CoreElements
open Sutil.DaisyUI

// For the best Tailwind experience, install the 'Tailwind CSS IntelliSense' extension.
// See README.md for full details.

let increment number = number + 1
let decrement number = number - 1

let view () =
  let counter = Store.make 0

  Html.div [
    disposeOnUnmount [ counter ]

    Bind.el (
      counter,
      fun count ->
        Html.p [
          Attr.className "text-green-600"
          Attr.text (string count)
        ]
    )

    Daisy.Button.button [
      Daisy.Button.small
      Daisy.Button.primary
      Attr.text "Increment"
      onClick (fun _ -> Store.modify increment counter) []
    ]
    Daisy.Button.button [
      Daisy.Button.small
      Daisy.Button.primary
      Attr.text "Decrement"
      onClick (fun _ -> Store.modify decrement counter) []
    ]
  ]

Program.mount ("sutil-app", view ()) |> ignore
