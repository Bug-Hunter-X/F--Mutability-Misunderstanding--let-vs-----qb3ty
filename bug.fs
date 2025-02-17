let mutable x = 10
let mutable y = 20
let add x y = x + y
printf "%d" (add x y) //This will print 30
x <- 15
printf "%d" (add x y) //This will print 35, demonstrating mutability

//However, if you try to use a let binding to create a new value for x, you will not be able to modify x within the let binding
let newX = x + 5
printf "%d" newX // This will print 20
printf "%d" x // This will still print 15

//In other words, the variable x is still 15 despite assigning 20 to newX. That is because x is a separate variable from newX
//To modify the original x, you must use the <- operator. Otherwise, it is considered as creating a new variable rather than modifying an existing one
