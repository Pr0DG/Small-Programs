#include <iostream>
#include <iomanip>
#include <fstream>
#include <vector>

struct mT {
    int tm_hour;
    int tm_min;
};

int main(int argc, char* argv[]) {
	std::ifstream input(argv[1]);
	std::vector<int> v1;
	char c;
	for(struct mT t; input >> t.tm_hour >> c >> t.tm_min;)
		v1.push_back(t.tm_hour*100+t.tm_min);
	for(struct mT t; std::cin >> t.tm_hour >> c >> t.tm_min;)
		for(unsigned i=0; i<v1.size(); ++i) {
			if(t.tm_hour*100+t.tm_min <= v1[i]) {
				if(v1[i]%100 < 10)
					std::cout << v1[i]/100 << ":0" << v1[i]%100 << std::endl;
				else
					std::cout << v1[i]/100 << ':' << v1[i]%100 << std::endl;
				break;}
			else if( v1[v1.size()-1] < t.tm_hour*100+t.tm_min) {
				if(v1[0]%100 < 10)
					std::cout << v1[0]/100 << ":0" << v1[0]%100 << std::endl;
				else
					std::cout << v1[0]/100 << ':' << v1[0]%100 << std::endl;
				break;}}
}
