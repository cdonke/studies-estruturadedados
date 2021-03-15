# Bubble Sorting
- **In-place:** uses small amount of extra memory
- **Unstable**: There is no garantee that the original order is preserver.
- Simillar to Bubble Sort

It has a wall, initially set to the end of the array.

We select the largest element at each pass.
At the beginning of each pass, we consider the largest element as the first one, and set the iterator as the 2nd one.

```
for(int i=0; i < array.Length; i++) { /* ... */ };

var largest = 0
var iterator = i + 1
```

At each pass, we increment the iterator, until we reach the wall, searching for the largest element.
When we find the a larger element compared to the current largest, we change the `largest` index to the current.
```
largest = i;
```

Then we swap the biggest element with the last one, and decrement the wall.


## Caracteristicas
- **Time complexity:** O(n^2)
- **Space efficiency:** O(1)
- **Degrades rapidly** - Though usually fast than Bubble Sort


## Benchmark
