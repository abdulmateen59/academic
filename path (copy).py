import itertools

class touristNode:
    def __init__(self, a_state, b_state,  id=0):

        max =0
        if len(b_state)==0:
            max =0

        elif len(b_state)==1:
            max = b_state[0]
        else:
            max = b_state[0]
            for i in b_state:
                if i>max:
                    max=i
        
        self.A = a_state
        self.B = b_state
        self.id = id
        self.cross_to_B = False
        self.parent = None
        self.g = 0 + max


def make_state_space(AA, b):
    graph ={}
    nodes = []
    for i in range(len(AA)):
        nodes.append( touristNode(AA[i],b[i], i))
        
    for i in range(len(nodes)):
        node = nodes[i]
        graph[node] = []
        if i==0:
            nodes[i].cross_to_B = True
            for j in range(1,7):    #1 to 6
                graph[node].append(nodes[j])
        elif i>0 and i<7:           #i = 1 to 6
            nodes[i].cross_to_B = False
            for j in range(7,11):   #j = 7 to 10
##                j_B = []
##                for tourist in nodes[i].B:
##                    if tourist not in nodes[j].B:
##                        j_B.append(tourist)
                #Above 4 lines of code can be replaced by the following 1 line of code
                j_B = [x for x in nodes[i].B if x not in nodes[j].B]
                if j_B + nodes[i].A == nodes[j].A:
                    graph[node].append(nodes[j])
        elif i>6 and i<11:          #i = 7 to 10
            nodes[i].cross_to_B = True
            for j in range(11,15):  #j = 11 to 14
                #If there is a tourist in nodes[i].A that is also present in nodes[j].B
                #That means the tourist travelled from nodes[i] to nodes[j]
                j_B = [x for x in nodes[j].B if x in nodes[i].A]
                if nodes[j].A+j_B==nodes[i].A:
                    graph[node].append(nodes[j])

        elif i>10 and i<15:
            nodes[i].cross_to_B = False
            for j in range(15,21):  #j = 15 to 20
                j_B = []
                for tourist in nodes[i].B:
                    if tourist not in nodes[j].B:
                        j_B.append(tourist)
                
                if nodes[i].A+j_B==nodes[j].A:
                    graph[node].append(nodes[j])
                    
        elif i>14 and i<21:
            nodes[i].cross_to_B = True
            graph[node].append(nodes[21])
    
    return graph, nodes
##############################################
def astarsearch(graph, start, goal, path=[]):
    paths = [ ]
    cost =0 
    paths.append(start)
    start1 =start
    count=0
    minn=0
    for node in graph[start]:
        if count == 0:
            minn =node.g
            cost = node.g
            paths.append(node)
            start1 =node
            count =count+1
            continue
        else:
            if node.g <minn:
                minn = node.g
                cost = node.g
                paths.pop()
                paths.append(node)
                start1 = node            
    count=0
    mx=0
    cost2 = 0
    for node in graph[start1]:
        if count == 0:
            mx =node.B[0]
            cost2 = node.g
            paths.append(node)
            start =node
            count =count+1
            continue
        else:
            if node.B[0] >mx:
                mx = node.B[0]
                cost2 = node.g
                paths.pop()
                paths.append(node)
                start = node
    count=0
    minn=0
    cost3 = 0
    for node in graph[start]:
    
        if count == 0:
            minn =node.g
            cost3 = node.g
            paths.append(node)
            start1 =node
            count =count+1
            continue
        else:
            if node.g <minn:
                minn = node.g
                cost3 = node.g
                paths.pop()
                paths.append(node)
                start1 = node
    count=0
    minn=0
    cost4 = 0
    for node in graph[start1]:
        if count == 0:
            minn =node.A[1]
            cost4 = node.A[1]
            paths.append(node)
            start =node
            count =count+1
            continue
        else:
            if node.A[1] <minn:
                minn = node.A[1]
                cost4 = node.A[1]
                paths.pop()
                paths.append(node)
                start = node
    cost5=0
    for node in graph[start]:
        cost5=minn
        paths.append(node)
    tot_cost= cost+cost2+cost3+cost4+cost5    
    return paths,tot_cost

###########################################

if __name__ == "__main__":
    
    A=[]
    for i in range(0,4):
        print("Enter speed of Tourist # ",i+1, ": ")
        A.append( int(input("")))
    A.sort()
    print("A",A)
    AA=[A]
    AA = (list(itertools.combinations(A, r=2))) 
    c = [list(i) for i in AA]                   #6 elements
    AA=(list(itertools.combinations(A, r=3)))
    d = [list(i) for i in AA]                   #4 elements
    AA=(list(itertools.combinations(A, r=1)))
    e = [list(i) for i in AA]                   #4 elements
    print(AA)
    
    AA=[A]          #1 element
    AA.extend(c)    #6 elements
    AA.extend(d)    #4 elements
    AA.extend(e)    #4 elements
    AA.extend(c)    #6 elements
    AA.append([])   #1 element
    print ("AA: ", AA)
    print ("len(AA): ", len(AA))
    b=[[]]
    for a_list in AA:
        b_list= []
        for tourist in A:
            if tourist not in a_list:
                b_list.append(tourist)
        b.extend([b_list])
    b.pop(0)
    print("b: ", b)
    print ("len(b): ", len(b))

    graph, nodes = make_state_space(AA,b)

    start = nodes[0]
    goal = nodes[len(nodes)-1]
    successful_path, cost = astarsearch(graph, start, goal)

    print("\n\n<<<<---------Complete Path-------->>>>\n\n")
    counter=0
    for node in successful_path:
        print("\nNode: ",counter)
        print(node.A)
        print(node.B)
        counter=counter+1

    print("Cost:",cost)
    

