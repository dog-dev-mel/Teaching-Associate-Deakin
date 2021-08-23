#Standard deviation, population standard deviation总体标准差，母体标准差，R采用的 /n-1 后开方
#Standard deviation常指样本标准差

#1、样本的标准偏差 ≠ 总体的标准偏差 ≠ 统计学标准偏差

#2、在总体符合正态分布的前提下：总体的标准偏差=统计学标准偏差

#3、当样本有代表性时：样本的标准偏差≈总体的标准偏差。即，通过样本的标准偏差可以估计总体的标准偏差。

#((1-2.5)^2+(2-2.5)^2+(3-2.5)^2+(4-2.5)^2)/4
sd(c(1,2,3,4))
#


#Uniform distribution vs normal distribution vs Poisson distribution vs Binomial distribution vs Exponential distribution
#Box-Muller-Wiener   Uniform distribution vs normal distribution



WAM <- function(x,w) {
    sum(w*x)
}

WAM <- function(x,w) {
    w <- w/sum(w)
    sum(w*x)
}

PM <- function(x,p) { # 1. pre-defining the function inputs
    if(p == 0) { # 2. condition for `if' statement
        prod(x)^(1/length(x)) # 3. what to do when (p==0) is TRUE
    }
    else {(mean(x^p))^(1/p)} # 4. what to do when (p==0) is FALSE
}

WPM <- function(x,w,p) { # 1. pre-defining the inputs
    if(p == 0) {prod(x^w)} # 2. weighted geometric mean if p=0
    else {sum(w*(x^p))^(1/p)} # 3. our calculation which will also
} # be the output


WPM <- function(x,w=array(1/length(x),length(x)),p=1) { # 1. pre-defining the inputs
    if(p == 0) {prod(x^w)} # 2. weighted geometric mean if p=0
    else {sum(w*(x^p))^(1/p)} # 3. our calculation which will also
} # be the output

WPM(c(0.6,0.7,0.8,0.9),p=2)    

Wmed <- function(x,w) { # 1. function inputs
    w <- w/sum(w) # 2. normalise weights
    n <- length(x)
    w <- w[order(x)] # 3. sort weights by inputs
    x <- sort(x) # 4. sort inputs
    out <- x[1] # 5. set starting value
    for(i in 1:(n-1)) { # 6. for each i, we check
        if(sum(w[1:i]) < 0.5) out <- x[i+1] # to see if the weights
    } # are still below 50%,
    out # once they're not, we stop
} # updating the output    


# From Week 3 Annotated Lectures 

# Aggregation Parameters Example (Slide 10)
w <- c(0.5, 0.2, 0.3)
x1 <- c(0.6, 0.7, 0.1)
x2 <- c(0.7, 0.7, 0.1)
x3 <- c(0.6, 0.8, 0.1)
WAM(w,x) # Should be 0.47, 0.52, 0.49

# Weighted Power Means (Geometric Mean) Example
w <- c(0.5, 0.2, 0.3)
x1 <- c(0.7, 0.6, 0.3)
x2 <- c(0.8, 0.6, 0.3)
x3 <- c(0.7, 0.6, 0.4)
WPM(x, w, 0)
# Results: 0.5264, 0.5627, 0.5738

# Weighted Median Example (Slide 30)
w1 <- c(0.32, 0.08, 0.20, 0.06, 0.10, 0.24)
x1 <- c(0.78, 0.45, 0.03, 0.27, 0.10, 0.45)
Wmed(x,w)

# Result should be 0.45
w2 <- c(0.1, 0.4, 0.3, 0.2)
x2 <- c(0.3, 0.7, 0.8, 0.2)
# Result should be 0.7

# Borda Count Example
x <- array(c(9,7,4,6,7,8,4,6,8), c(3,3))
w <- c(2,1,0)
wNormalised <- c(2/3, 1/3, 0)
Borda(x,w)
# Result should be 2, 3, 4 - how is it different when you use the normalised weights instead?


#Exercise 2
x[,1] <- rank(x[,1])

x[x==3] <- 10

x[x==3] <- 10
x[x==2] <- 4
x[x==1] <- 2

# 1. function inputs
# 2. vector to hold final scores
# 3. convert each column to ranks
# 4. convert all of the ranks to the w scores
# 5. add the scores for each candidate
Borda <- function(x,w) {
    total.scores <- array(0,nrow(x))
    for(j in 1:ncol(x)) {
        x[,j] <- rank(x[,j])
    }
    for(i in 1:length(w)) {
        x[x==i] <- w[i]
    }
    for(i in 1:nrow(x)) {
        total.scores[i] <- sum(x[i,])
    }
    total.scores
}