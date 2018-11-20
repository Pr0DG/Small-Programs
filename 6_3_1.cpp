#include <iostream>
#include <fstream>
#include <sstream>
#include <string>

int main(int argc, char* argv[]) {
    std::ifstream input(argv[2]);
    for(std::string lineS; std::getline(input, lineS);) {
        std::string word;
        std::istringstream stream(lineS);
        int i = 0;
        for(; (i < std::stod(argv[1])) && (stream >> word); ++i);
        if(i < std::stod(argv[1])) std::cout <<"Out: " <<std::endl;
        else std::cout <<"Out: "<< word << std::endl;
    }
}
