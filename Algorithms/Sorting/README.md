# Heap Sorting
O algoritmo heapsort é um algoritmo de ordenação generalista, e faz parte da família de algoritmos de ordenação por seleção. Foi desenvolvido em 1964 por Robert W. Floyd e J.W.J Williams.

![Heapsort](https://upload.wikimedia.org/wikipedia/commons/1/1b/Sorting_heapsort_anim.gif)

## Links
- https://www.youtube.com/watch?v=zSYOMJ1E52A
- https://pt.wikipedia.org/wiki/Heapsort

## Caracteristicas
- Comparações no pior caso: 2n log2n + O(n) é o mesmo que 2n log n + O(n)
- Trocas no pior caso: n log2n + O(n) é o mesmo que n log n + O(n)
- Melhor e pior caso: O(n log2n) é o mesmo que O(n log n)

## Benchmark
| Method |              A |     Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------- |--------------- |---------:|---------:|---------:|-------:|------:|------:|----------:|
|   Sort | Int32[1000000] | 17.57 ns | 0.465 ns | 1.068 ns | 0.0095 |     - |     - |      40 B |
|   Sort |  Int32[100000] | 18.03 ns | 0.461 ns | 0.866 ns | 0.0095 |     - |     - |      40 B |
|   Sort |   Int32[10000] | 26.41 ns | 0.597 ns | 0.663 ns | 0.0114 |     - |     - |      48 B |
|   Sort |      Int32[10] | 26.34 ns | 0.621 ns | 0.807 ns | 0.0114 |     - |     - |      48 B |
|   Sort |      Int32[50] | 22.52 ns | 0.481 ns | 0.609 ns | 0.0095 |     - |     - |      40 B |