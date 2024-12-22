let x = ref 10
let y = ref 20

let add () = !x + !y

let z = add()

printf "%d\n" z

x := 100
y := 200

let z2 = add()

printf "%d\n" z2 // z2 is 300 now