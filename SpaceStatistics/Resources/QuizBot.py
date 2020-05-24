import vk_api

def main():
    """txt login pass offset """
    commandFile = open('commandFileQuizBot.op','r')
    login = commandFile.readline()
    password =commandFile.readline().rstrip()
    print(password)
    offsetPost = int(commandFile.readline())
    vk_session = vk_api.VkApi(login, password)

    try:
        vk_session.auth(token_only=True)
    except vk_api.AuthError as error_msg:
        print(error_msg)
        return

    vk = vk_session.get_api()
    myfile = open('usersvoite.txt','w')
    """ VkApi.method позволяет выполнять запросы к API. В этом примере
        используется метод wall.get (https://vk.com/dev/wall.get) с параметром
        count = 1, т.е. мы получаем один последний пост со стены текущего
        пользователя.
    """
    #82
   # ответы
    realotv = {
        1:2,
        2:2,
        3:0,
        4:1,
        5:3,
        6:0,
        7:1
        }
    resp2 = vk.groups.get(count=10,fields='name')
    response = vk.wall.get(owner_id=-resp2['items'][0],extended = 1,offset = offsetPost,fields ="poll",count = 6)
    c = 0;
    for c in range(1,len(response['items']),1):
        print('-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_',c);
        it = response['items'][c]# Используем метод wall.get
        print(it['text']);
        at = it['attachments']
        for k in range(len(at)):
            if at[k]['type'] == 'poll':
               pollid = at[k]['poll']['id']
               print('c = ',c)
               print(realotv[c])
               voites = vk.polls.getVoters(poll_id = pollid,answer_ids = at[k]['poll']['answers'][realotv[c]]['id'])[0]['users']
               users = vk.users.get(user_ids = voites['items'],fields = 'id,first_name,last_name')
               myfile.write('*')
               for a in range(voites['count']):
                   print(users[a])
                   myfile.write(str(users[a]['id'])+' '+users[a]['first_name']+' '+users[a]['last_name']+'#')
    myfile.close()
if __name__ == '__main__':
    main()
