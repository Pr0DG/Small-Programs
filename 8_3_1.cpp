#include <iostream>
#include <vector>
#include <algorithm>
#include <cstdlib>
#include <ctime>

std::vector<int> permutation(int n) {
    std::vector<int> v(n);
    std::iota(v.begin(),v.end(),1);
    std::random_shuffle(v.begin(),v.end());
    return v;
}


int main() {
std::srand(std::time(nullptr));
std::vector<int> vector = permutation(5);
for (int element: vector) {
std::cout << element << " "; }
std::cout << std::endl; }
