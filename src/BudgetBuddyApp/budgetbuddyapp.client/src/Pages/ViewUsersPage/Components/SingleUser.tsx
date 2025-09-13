import { Avatar, Flex, Stack, Text  } from "@mantine/core";

interface SingleUserProps{
    name:string,
    email:string
}

export default function SingleUser(user_data: SingleUserProps)
{
    return(
         <Flex
      gap="8"
      justify="flex-start"
      align="center"
      direction="row"
      p={0}
      m={0}
    >
         <Avatar radius="xl" />
         <Stack
      align="flex-start"
      justify="center"
      gap="0"
      p={0}
      m={0}
      w={"100%"}
    >
      <Text size="sm">{user_data.name}</Text>
      <Text size="xs" fs="italic" c={"darkgrey"}>{user_data.name}</Text>
    </Stack>
    </Flex>
     
    );
}