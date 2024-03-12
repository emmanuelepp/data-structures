package main

type Node struct {
	value int
	next  *Node
}

type Stack struct {
	top    *Node
	Length int
}
