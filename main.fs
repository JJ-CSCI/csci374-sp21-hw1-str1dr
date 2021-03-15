module Assignment

// Problem 1
let rec tribn n =
    // write your code here
    if n <= 0 then 0
    else if n = 1 then 1
    else if n = 2 then 1
    else tribn (n - 1) + tribn (n - 2) + tribn (n - 3)

// Problem 2
let tribn2 n =
    
  let rec list1 (lst: int list) = 
        if List.isEmpty then []
        else List.head + (List.tail.head + List.tail.tail.head + list.tail.tail.tail.head)
      
    
  if n <= 0 then 0
  else if n = 1 then 1
  else if n = 2 then 1
  else tribn2 (n - 1) + tribn2 (n - 2) + tribn2 (n - 3)
  (list1 n)
    
   
      
   

    (*1. Implement a function which takes a list of integers and adds the sum of the top four elements to the head of the list (e.g., in F#, 1::1::1::[] should become 3::1::1::1::[]).
2. Implement a recursive function which computes the `n`th Tribonacci number in linear time. This function may use a linear amount of space to compute its result, but the number of recursive calls it makes must be linear in `n`.

Your task is to follow the three steps above, in order to implement the recursive function `tribn2` in F#.
- Hint: Try to define auxiliary functions first before taking on `tribn2` function. You do not have to use auxiliary functions in your `tribn2`, but they provide an insight on how to implement the `tribn2` function.
*)

// Problem 3
let rec last lst = []
    // write your code here

    let lastValue = last.[last.Length - 1]

// Problem 4
let fourth (lst: int list) =
  0
    // write your code here
   if List.isEmpty lst then 0
    else
    let h = List.head lst
    let t = List.tail lst
    if
    else fourth
    //Write a function `fourth int list -> int` that takes an `int list` and returns the fourth element of that list, if such an element exists. If the list has fewer than four elements, return 0.


// Problem 5
let everyfourth (lst:int list) =
    // write your code here
    []

// Problem 6
let rec take n (lst:int list) =
    // write your code here
    []

// Problem 7
let rec drop n (lst:int list) = 0
    // write your code here
    //Write a function `drop : int -> int list -> int list` such that `drop n lst` returns all but the first `n` elements of `lst`. If `lst` has fewer than `n` elements, return the empty list.
    
