# ITFDN120_Assignment1

Problem:

After watching the binary number video, did you notice the YouTube url?

https://www.youtube.com/watch?v=LpuPe81bc2w
Write the code to convert the base-62 number to base-10.

Submit your program (C#, Python, Javascript, ...) as well as the decimal number value for LpuPe81bc2w.

Hint: Use an array/string that contains all the numbers and digits: "0123456789AB...YZab...yz"


Notes:

We want a bi-directional mapping of a given string using a Base 62 encoding schema.
This is 62 letters: a-z A-Z 0-9.
Use the modulus from diving by 62, then divide by 62, and repeat.