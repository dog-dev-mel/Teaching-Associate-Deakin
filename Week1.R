# Exercise 1
#Addition, 5 plus 2
5 + 2

#Subtraction, 6 minus 8
6 - 8

#Multiplication, 3 times/multiplies 4
3*4

#Division, 3 is divided by 4
3/4

#Powers, 3 to the 4 or 3 super/superscript 4
3^4
#---------------------------------------------------------------------------------------------------
#---------------------------------------------------------------------------------------------------

# Exercise 2
#Set 5+2 to variable a
#Using less than symbol with dash assign value to the variable a 
#To assign a negative number, -5, to the a
a <- -5
a

#To assign a positve number, +5, to the b
b <- +5
b

#Add two variables, assign the result of a plus b to the variable c
c <- a + b

#A variable can be along with a full stop symbol
the.value <- 10

#A variable can be along with a underscore/underline/underdash/low line/low dash symbol
the.value_1 <- 5

#A variable times another variable, assign its result to the variable d 
d <- the.value * the.value_1

#We also can use the euqla symbol to assign a value to a variable
e = 1000

#using function c{base} to combine Values into a Vector or List
vector_a <- c(3,2,1,0) #open parenthesis 3,2,1,0 comma left parenthesis
vector_a
mode(vector_a)

#using a set of sequential numbers to combine Values into a Vector or List
vector_b <- 4:8  #4 colon 8
vector_b
mode(vector_b)

#Define a empty vector using the array() command
#The first one is the default entry of the array, e.g. 0
#The second argument gives the length.
vector_c <- array(0,3)
vector_c
mode(vector_c)

vector_d <- array(1,10)
vector_d
mode(vector_d)

vector_e <- array(2,200)
vector_e
mode(vector_e)

#Combine the array() and c() commands 
#for creating a complex vector includinga small sub-sequence
sub_sequence_vector <- array(c(1,2,3,0),200)
sub_sequence_vector
mode(sub_sequence_vector)

#You can regard the vertor as a one-dimension array
#---------------------------------------------------------------------------------------------------
#---------------------------------------------------------------------------------------------------

# Exercise 3
#Basic mathmatical operations between a vector and a normal number value
c(1,2,3) + 3
c(1,2,3) * 4
c(1,2,3) ^ 2
#---------------------------------------------------------------------------------------------------
#---------------------------------------------------------------------------------------------------


# Exercise 4
#Basic mathmatical operations on vectors
vector_1 <- c(1,6,7,9)
vector_2 <- c(-1,2,1,-2)
vector_1 + vector_2
vector_1 - vector_2
vector_1 * vector_2
vector_1 / vector_2
vector_1 ^ vector_2
#---------------------------------------------------------------------------------------------------
#---------------------------------------------------------------------------------------------------


# Exercise 5
#Call the R language Build-in functions
a <- c(1,8,3,9)
b <- c(2,2,1,1)
d <- c(3,4,6,81,9)

#the sum of vector a is 1+8+3+9
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


#Create a self-defining function
our.mean <- function(x) {
    sum(x)/length(x)
}

our.mean(c(1,2,3,4,5))
#---------------------------------------------------------------------------------------------------
#---------------------------------------------------------------------------------------------------








nothing.happens <- function(x) {
    sum(x) + 2
    x = 10
}
nothing.happens(c(1,2,3,4))


#we don't need to do any temporary assignment of values throughout.
#However we could if we wanted to.
our.mean.2 <- function(x) {
    n <- length(x)
    s <- sum(x)
    output <- s/n
    output
}

our.mean.2(c(1,2,3,4,5))

#vectors into a matrix using cbind (column bind) or rbind (row bind)
cbind(c(1,2,3,7,9), c(21, 2, 1, 5, 6))
cbind(c(1,2,3,7,9), c(1,9,7,2,1), array(6,5))
rbind(c(3,6,1,92), c(10,3,1))
rbind(c(3,6,1,92), c(3,2,1,8))
rbind(c(3,6,1,92), c(4,1,12,1,2))