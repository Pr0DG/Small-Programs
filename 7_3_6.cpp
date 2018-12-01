#include <iostream>
#include <vector>

void accumulate(std::vector<double>::iterator begin, std::vector<double>::iterator en) {
    for(;begin<en;*(begin+1)+=*begin,++begin)
         if(begin+1==en) return;
}

int main() {
    std::vector<double> vector {3.1, 2.7, -0.5, 0.1, 4.3};
    accumulate(vector.begin()+1, vector.end()-2);
    for (double element: vector) {
        std::cout << element << " "; }
    std::cout << std::endl;
}
