#include <iostream>

using namespace std;

class Node
{
public:
    int value;
    Node *next;

    Node(int value)
    {
        this->value = value;
        next = nullptr;
    }
};

class Stack
{
private:
    Node *top;
    int height;

public:
    Stack(int value)
    {
        Node *newNode = new Node(value);
        top = newNode;
        height = 1;
    }

    void push(int value)
    {
        Node *newNode = new Node(value);
        newNode->next = top;
        top = newNode;
        height++;
    }

    int pop()
    {
        if (height == 0)
            return INT16_MIN;

        Node *temp = top;
        int poppedValue = top->value;
        top = top->next;
        delete temp;
        height--;

        return poppedValue;
    }

    void printStack()
    {
        Node *temp = top;
        while (temp)
        {
            cout << temp->value << endl;
            temp = temp->next;
        }
    }

    void getTop()
    {
        cout << "Top: " << top->value << endl;
    }

    void getHeight()
    {
        cout << "Height: " << height << endl;
    }
};

int main()
{
    Stack *stack = new Stack(1);

    stack->getTop();
    stack->getHeight();
    stack->push(2);
    stack->push(3);
    stack->printStack();
    stack->pop();
    stack->printStack();
}