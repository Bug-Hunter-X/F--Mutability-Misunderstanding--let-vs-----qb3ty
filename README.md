# F# Mutability Gotcha: let vs. <- 

This example highlights a common source of confusion for F# newcomers: the distinction between modifying mutable variables using the `<-` operator and creating new bindings with `let`.

The `bug.fs` file contains code that showcases this behavior.  The `bugSolution.fs` file offers explanations and demonstrates best practices.

## Key Point

While `let` bindings appear similar to variable assignments in other languages, in F# they create entirely new immutable values. To modify an existing mutable variable, you *must* use the `<-` operator.  Failing to do so will lead to unexpected behavior where variables are not modified as intended.