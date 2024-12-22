# F# Mutable Variables and Unexpected Behavior

This example demonstrates a common pitfall in F# when dealing with mutable variables.  While F# encourages immutability, mutable variables can be used, but their behavior can be surprising if you're not careful.  This example showcases how a calculation based on mutable variables isn't automatically recomputed when those variables change.

## Bug

The `bug.fs` file shows a simple addition function using mutable variables.  The value of `z` is calculated once, and despite the change in `x` and `y` the value of `z` is not updated. This happens because F# evaluates expressions only once unless explicitly told otherwise.

## Solution

The `bugSolution.fs` file provides a corrected version. The solution involves recomputing `z` after changes to `x` and `y`.  Alternatively, we could use a function that takes `x` and `y` as arguments each time it needs to perform the addition, maintaining immutability and avoiding this issue entirely.

This example highlights the importance of understanding how F# evaluates expressions and how to manage mutable state effectively to prevent unexpected behavior.