#include <iostream>
#include "transformer.hpp"

int main(int argc, char* argv[]) {	
	int value = 0;
	MoveAgent* agent = new MoveAgent(30);
	std::cin >> value;
	std::cout << "Start value: " << value << std::endl;
	std::cout << "Transformed: " << agent->transform(value) << std::endl; 
}
