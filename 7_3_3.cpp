#include <iostream>
#include <vector>

std::vector<int>::const_iterator find(std::vector<int>::const_iterator it, std::vector<int>::const_iterator end, int x) {
    for(;it < end;++it)
        if(*it == x) return it;
    return end;
}


int main() {
const std::vector<int> vector {3, -1, 7, 12, -5, 7, 10};
std::cout << find(vector.begin(), vector.end(), 399) - vector.begin() << std::endl; }
