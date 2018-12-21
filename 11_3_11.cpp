#include <iostream>

class Set {
		bool set[255];
		unsigned sizeS = 0;
	public:
		Set& insert(char newC) {
				if(!(set[(int)newC])) ++sizeS;
				set[(int)newC]= true;
				return *this; 
			}
		Set& remove(char delC) {
				if(set[(int)delC]) --sizeS;
				set[(int)delC]= false;
				return *this; 
			}
		bool contains(char checkC) {
				return set[(int)checkC];
			}
		unsigned size() {return sizeS;}	
};

int main() {
Set set = Set().insert('a').insert('b').remove('b').remove('c').insert('d');
std::cout << set.size() << std::endl << std::boolalpha;
std::cout << set.contains('a') << " " << set.contains('b') << " "
<< set.contains('c') << " " << set.contains('d') << std::endl; }
