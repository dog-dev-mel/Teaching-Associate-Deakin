# Exercise 1
#Addition
5 + 2
#Subtraction
6 - 8
#Multiplication
3*4
#Division
3/4
#Powers
3^4


# Exercise 2
#Set 5+2 to variable a
a <- 5 + 2
a
#Set 6-8 to variable b
b <- 6 - 8
b
#Set 3*4 to variable d
d <- 3 * 4
d
#Set 3/4 to variable e
e <- 3 / 4
e
#Add a to e
a + b + d + e
#using function c{base} to combine Values into a Vector or List
vector_a <- c(3,2,1,0)
vector_a
#using a set of sequential numbers to combine Values into a Vector or List
vector_b <- 4:8
vector_b
#Define a empty vector using the array() command
#The first one is the default entry of the array, e.g. 0
#The second argument gives the length.
vector_c <- array(0,3)
vector_c
vector_d <- array(1,10)
vector_d
vector_e <- array(2,200)
vector_e
#Combine the array() and c() commands 
#for creating a complex vector includinga small sub-sequence
sub_sequence_vector <- array(c(1,2,3,0),200)
sub_sequence_vector


# Exercise 3
#Basic operations on vectors
c(1,2,3) + 3
c(1,2,3) * 4
c(1,2,3) ^ 2
c(2,3) + c(5,-1)
#vectors into a matrix using cbind (column bind) or rbind (row bind)
cbind(c(1,2,3,7,9), c(21, 2, 1, 5, 6))
cbind(c(1,2,3,7,9), c(1,9,7,2,1), array(6,5))
rbind(c(3,6,1,92), c(10,3,1))
rbind(c(3,6,1,92), c(3,2,1,8))
rbind(c(3,6,1,92), c(4,1,12,1,2))

# Exercise 4
#Assign the two vectors
a <- c(1,6,7,9)
b <- c(-1,2,1,-2)
a + b
a - b
a * b
a / b
a ^ b

v1 = c(1,6,7,9)
v2 = c(-1,2,1,-2)
v1 + v2
v1 - v2
v1 * v2
v1 / v2
v1 ^ v2


# Exercise 5
#Existing functions
a <- c(1,8,3,9)
b <- c(2,2,1,1)
d <- c(3,4,6,81,9)
#the sum of a is 1+8+3+9
sum(a)
#the product of c is 3*4*6*81*9
prod(d)
# the length of d is 5
length(d)
#the sum of a*b is  1*2+8*2+3*1+9*1
sum(a*b)
#the sum of a^b is  1^2+8^2+3^1+9^1
sum(a^b)
#the power (1/the length of b) of the product of vector a is (1*8*3*9)^(1/4)
prod(a)^(1/length(b))
#the min of d is 3
min(d)
#the max of a and d is 1 
max(a,d)
#the min of the (max a and max b) is min (9,2) is 2
min(max(a),max(b))
#the median of a is (8+3)/2
median(a)
#the mean of a is (1+8+3+9)/4
mean(a)


#Function Creating
our.mean <- function(x) {
    sum(x)/length(x)
}
#we don't need to do any temporary assignment of values throughout.
#However we could if we wanted to.
our.mean.2 <- function(x) {
    n <- length(x)
    s <- sum(x)
    output <- s/n
    output
}

our.mean(a)
our.mean.2(a)