#include <iostream>
#include <vector>
#include <string>

int main() {
    std::vector<std::string> v;
    std::string str;

    while(std::cin >> str)
        v.push_back(str);
    for(int i = 0; i < v.size(); ++i)
        for(int j = 0; j < v.size()-1; ++j) {
            if(v[j] > v[j+1]) {
                std::string tmp = v[j];
                v[j] = v[j+1];
                v[j+1] = tmp;
            }
        }
    for(std::string el : v)
        std::cout << el << " ";
}

/*
for(unsigned i = 0; i < v.size()-1;++i)
            if(str > v[i] && str < v[i+1])
                v.emplace(v.begin()+i,str);}
                */
