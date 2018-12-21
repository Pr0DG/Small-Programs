#include <iostream>

class Lights {
		bool redLightState;
		bool yellowLightState;
		bool greenLightState;	
		unsigned state = 0;
	public:
		Lights() : redLightState(true), yellowLightState(false), greenLightState(false){}
		bool red() {return redLightState;}
		bool yellow() {return yellowLightState;}
		bool green() {return greenLightState;}
		void flip(){
			switch(state) {
				case 0: yellowLightState = true;
						++state;
						break;
				case 1:	redLightState = false;
						yellowLightState = false;
						greenLightState = true;
						++state;
						break;
				case 2: yellowLightState = true;
						greenLightState = false;
						++state;
						break;
				case 3: redLightState = true;
						yellowLightState = false;
						state=0;
			}
		}
};

int main() {
std::cout << std::boolalpha;
Lights lights;
std::cout << lights.red() << " " << lights.yellow() << " " << lights.green() << std::endl;
lights.flip();
std::cout << lights.red() << " " << lights.yellow() << " " << lights.green() << std::endl;
lights.flip();
std::cout << lights.red() << " " << lights.yellow() << " " << lights.green() << std::endl;
lights.flip();
std::cout << lights.red() << " " << lights.yellow() << " " << lights.green() << std::endl;
lights.flip();
std::cout << lights.red() << " " << lights.yellow() << " " << lights.green() << std::endl; }
