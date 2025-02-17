let mutable x = 10
let mutable y = 20
let add x y = x + y
printf "%d" (add x y) //This will print 30
x <- 15
printf "%d" (add x y) //This will print 35, demonstrating mutability

//To modify the original x, you must use the <- operator.  Using let creates a new immutable variable:
let newX = x + 5
printf "%d" newX // This will print 20
printf "%d" x // This will still print 15 because x is unchanged

//Best practice is to favor immutability unless mutation is absolutely necessary.
// Consider using `let` bindings instead of mutable variables whenever possible for cleaner and safer code.
//When using mutable variables, always use <- to clearly indicate mutation.
