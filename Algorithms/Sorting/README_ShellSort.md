# Shell Sorting
- **In-place:** uses small amount of extra memory
- **Unstable**: Changes the order of duplicate itens.

---

- Improvement of Insertion Sort
- It's fast on pre-sorted array
- **Basic Idea:** pre-sort the input and switch to Insertion Sort
- Gap is used for pre-sorting => swap distant elements.
- Shell sort starts with a "large" gap and gradually reduces it
  - When gap =1, Insertion Sort finishes the sorting process

---

- Shell sort performance depends on a concrete gap value
- in 99% of cases, you can rely on the "universal" sequence of gap values

1. Calculate the max gap < N/3, where N = array length
   ```csharp
   int gap=1;
   while (gap < array.Lenth / 3) 
      gap = 3 * gap + 1
   ```
1. Reduce gap at the end of each step to the outer loop:
   ```csharp
   while (gap >= 1) {
      // sorting
      // ...
      gap /= 3;
   }
   ```
   It gives the sequence: 1, 4, 13, 40, 121, 364, ..., (0.5*(3^k -1))

## Caracteristicas
- **Time complexity:** O(n^2)
  - Depends on how th gap value is calculated.
  - **Worst case:** O(n^(3/2))
  - **Best case:** O(n^(6/5))
- **Space efficiency:** O(1)

## Benchmark