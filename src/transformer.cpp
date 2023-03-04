#include "transformer.hpp"

MoveAgent::MoveAgent() {
	testValue = 0;
}

MoveAgent::MoveAgent(int num) {
	testValue = num;
}

int MoveAgent::transform(int num) {
	return num + testValue;
}
