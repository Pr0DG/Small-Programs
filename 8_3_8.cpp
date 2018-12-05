#include <iostream>
#include <vector>
#include <algorithm>

int main() {
    std::vector<int> v1, v2;
    int x;
    while(std::cin >> x)
        v1.push_back(x);
    std::sort(v1.begin(),v1.end());
    for(int i = 0; i < v1.size(); ++i) {
       int j = std::count(v1.begin()+i,v1.end(),v1[i]);
            if(j > 1) v2.push_back(v1[i]);
        i += j-1;
    }
    for(int el : v2)
        std::cout << el << " ";
}
