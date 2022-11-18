﻿using System;

namespace double_linked_list
{
    class Node
    {

        /* Node class represent the node of doubly linked list
         * It consists of the information part and links to
         * Its succeding and preceeding
         * In terms of the next and previous */

        public int noMhs;
        public string name;
        //point to the succeding node
        public Node next;
        //point to the preceeding node
        public Node prev;
    }

    class DoubleLinkedList
    {
        Node START;
    }
}