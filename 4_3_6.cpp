#include <fstream>

int main(int argc, char* argv[]) {
    std::ifstream input(argv[1]);
    std::ofstream output(argv[2]);
    char c;
    for(int i = 0; input.get(c);) {
        if(i == 0)
            output << ++i << " " << c;
        else if(i == 1)
            output << ++i << " " << c;
        else if(c == '\n')
            output << c << ++i << " ";
        else
            output << c;
    }
    input.close();
    output.close();
}
