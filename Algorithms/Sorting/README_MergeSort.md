# Merge Sorting

Recursive algorithm of the Divid-and-Conquer Approach.
Recursively, it splits the array in half, calling itself with each part, so:

let `A`, and array on `n elements`, so:
```
Merge-Sort(A, start, length):
	if (start < length):
		let q = (start + length)/2
		Merge-Sort(A, start, q);
		Merge-Sort(A, q+1, length);
		Merge(A, start, q, length);
```

`Merge-Sort` runs recursively splitting the array in `[n/2]` elements, and sorting them:

```csharp
Merge(A, start, middle, length):
	let i=0, j=0; // To hold sub-arrays index
	let n1 = middle-start+1; // To hold the length of the left array
	let n2 = length-middle; // To hold the length of the right array

	// the +1 here is to define a high enough number as a stop-sign.
	// Like a sentinel
	let L = [1..n1 + 1];
	let R = [1..n2 + 1];


	// Copy the contents of the A array into the sub arrays.
	for(i=0 to n1):
		L[i] = A[start+i];

	for i=0 to n2:
		R[i] = A[middle+i+1];

	// Define stop-sign
	L[n1] = Infinity
	R[n2] = Infinity

	// Sort. Comparing left with right.
	// If <, replace L[i] on A[k], and increment i
	// Otherwise, replace K[j] on A[k], and increment j;
	for k = start to length:
		if L[i] <= R[j]:
			A[k] = L[i];
			i = i+1;
		else
			A[k] = R[j];
			j = j+1;
 ```

## Benchmark