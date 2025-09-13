import { Stack, Text } from "@mantine/core";
import SingleUser from "./Components/SingleUser";

export default function ViewUsersPage(){

    return(
         <Stack
            p={0}
            m={0}
            w={"100%"}
              align="stretch"
              justify="center"
              gap="0"
            >
                <Text pb={"20px"} size="xl">Users</Text>
                <SingleUser name={"undefined"} email={"sfis@gmail"} />
                <hr style={{background:"#f1f1f1", width:"98%"}}/>
                <SingleUser name={"undefined"} email={""} />
                <hr style={{background:"#fbfbfb", width:"98%"}}/>
                <SingleUser name={"undefined"} email={""} />
                <hr style={{background:"lightgrey", width:"98%"}}/>
                <SingleUser name={"undefined"} email={""} />
                <hr style={{background:"lightgrey", width:"98%"}}/>
            </Stack>
    );
}