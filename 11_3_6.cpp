#include <iostream>

class Bottle {
		double size;
		double v;
	public:
		Bottle(double size) :size(size),v(){}
		double volume() {return v;}
		double fill(double fillV) {
			v+=(size-v > fillV) ? fillV : fillV=size-v;
			return fillV;
		}
		double pour(double pourV) {
			v-=(v > pourV) ? pourV : pourV=v;
			return pourV;
		}
};

int main() {
Bottle bottle(4.5);
std::cout << bottle.volume() << " ";
std::cout << bottle.fill(3.5) << " ";
std::cout << bottle.volume() << " ";
std::cout << bottle.pour(5.5) << " ";
std::cout << bottle.volume() << std::endl; }

