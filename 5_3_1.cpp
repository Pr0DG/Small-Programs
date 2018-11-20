#include <iostream>
#include <string>
#include <cctype>

std::string initials(std::string str) {
    std::string nStr;
    for(int i=0;i < str.length();++i) {
        if(nStr.empty() && str[i]!=' ') nStr += str[i];
        else if(!nStr.empty() && str[i] == ' ' && str[i+1] != ' ') nStr += str[i+1];
    }
    return nStr;
}

int main() {
    std::cout << initials("John Fitzgerald Kennedy") << std::endl;
    std::cout << initials(std::string("andy warhol")) << std::endl;
    std::cout << initials(std::string(" Cezary Kania")) <<"cos"<< std::endl;
    std::cout << initials(std::string("")) << "cos" << std::endl;
    std::cout << initials(std::string("a")) << std::endl;
}
