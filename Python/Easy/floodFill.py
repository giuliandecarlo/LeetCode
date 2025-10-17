def floodFill(image, sr, sc, color):
        start = image[sr][sc]

        def fill(x,y):
            if x < 0 or x >= len(image) or y < 0 or y >= len(image[0]):
                return
            if image[x][y] == color:
                return
            if image[x][y] != start:
                return
            
            image[x][y] = color
            fill(x-1,y)
            fill(x+1,y)
            fill(x,y-1)
            fill(x,y+1)
            
        fill(sr,sc)
        return image